import React, { useCallback, useEffect, useState } from 'react';
import { css } from "@emotion/core";
import ClipLoader from 'react-spinners/ClipLoader';
import { RiAlarmWarningLine } from 'react-icons/ri';
import moment from 'moment';

import Options from '../../../components/Options';
import Table from '../../../components/Table';
import ProcessOptions from '../../../components/ProcessOptions';

import api from '../../../services/api';
import { Error } from '../../../utils/toast';

import { Form, Warning } from './styles';

const cssspinner = css`
  display: block;
  margin: 0 auto;
  margin-top: 100px;
`;

const ProcessDetails = (props) => {
    const[columns, setColumns] = useState([]);
    const[id, setId] = useState();
    const[company, setCompany] = useState();
    const[date, setDate] = useState();
    const[sulamerica, setSulamerica] = useState([]);
    const[unimed, setUnimed] = useState([]);
    const[totalValue, setTotalValue] = useState(0);

    const[loading, setLoading] = useState(false);
    const[error, setError] = useState(false);

    const loadColumnControl = useCallback(async () => {
        try{
            setLoading(true);
            const company = props.match.params.company;
            const response = await api.get(`ColumnControl/get-company?company=${company}`);
            const columnsArray = []
            
            response.data.map((r, index) => {
                const obj = {
                    id: index,
                    description: r.field,
                    fieldCode: r.fieldCode
                }
                columnsArray.push(obj);
                return columnsArray;
            });
            setColumns(columnsArray);
        } catch {
            setError(true);
            Error("Falha ao carregar as colunas...");
        } finally {
            setLoading(false);
        }
    }, [props.match.params.company]);

    const loadData = useCallback(async () => {
        try{
            setLoading(true);
            const processId = props.match.params.id;
            const response = await api.get(`Process/${processId}`);
            
            setId(response.data.id);
            setCompany(response.data.title);
            setDate(response.data.startDate);

            setSulamerica(response.data.sulamericas);
            setUnimed(response.data.unimed);
        } catch {
            setError(true);
            Error("Falha ao carregar processo...");
        } finally {
            setLoading(false);
        }
    }, [props.match.params.id])

    const getTotalValue = useCallback(() => {
        let value = 0;
        if (unimed.length > 0) {
            unimed.map(u => {
                value += u.valorDespesa;
                return value;
            });
            setTotalValue(value);
        } else if (sulamerica.length > 0) {
            sulamerica.map(s => {
                value += s.valor
                return value;
            });
            setTotalValue(value);
        }
    }, [unimed, sulamerica]);

    useEffect(() => {
        loadColumnControl();
        loadData();
    }, [loadColumnControl, loadData])

    useEffect(() => {
        getTotalValue();
    }, [getTotalValue]);

    return (
        <>
            <Options url="/" active={true} />
            {loading ? 

                <ClipLoader css={cssspinner} />

            : 
                !error ? 
                    <> 
                        <Form>
                            <p>Código: {id}</p>
                            <p>Empresa: {company}</p>
                            <p>Data: {moment(date).format('DD/MM/YYYY')}</p>
                            <p>Valor Total: {Intl.NumberFormat('pt-BR', { style: 'currency', currency: 'BRL' }).format(totalValue)}</p>
                        </Form>

                        {sulamerica.length ? <Table columns={columns} data={sulamerica} /> : null}
                        
                        {unimed.length ? <Table columns={columns} data={unimed} /> : null}
                    </> 
                : 
                    <Warning>
                        <RiAlarmWarningLine color="#E74C3C" size={20} />
                        <span>Falha ao carregar processo</span>
                    </Warning>
                
                }
            <ProcessOptions uid={id} />
        </>
    )
}

export default ProcessDetails;
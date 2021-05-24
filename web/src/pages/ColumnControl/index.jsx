import React, { useCallback, useEffect, useState} from 'react';
import { css } from "@emotion/core";
import ClipLoader from 'react-spinners/ClipLoader';
import { Link } from 'react-router-dom';
import { RiAlarmWarningLine } from 'react-icons/ri';

import Options from '../../components/Options';
import SubHeader from '../../components/SubHeader';

import api from '../../services/api';
import { Error } from '../../utils/toast';

import { Content, Companies, Items, Warning } from './styles';

const cssspinner = css`
  display: block;
  margin: 0 auto;
  margin-top: 100px;
`;

const ColumnControls = () => {
    const[columnControl, setColumnControl] = useState([]);
    const[loading, setLoading] = useState(false);
    const[error, setError] = useState(false);

    const columns = useCallback(async () => {
        try {
            setLoading(true);
            const response = await api.get(`ColumnControl/companies`);
            setColumnControl(response.data);
        } catch {
            setError(true);
            Error("Falha ao carregar empresas...");
        } finally {
            setLoading(false);
        }
    }, []);

    useEffect(() => {
        columns();
    }, [columns])

    return(
        <>
            <Options url="/" active={true} />
            <SubHeader title="Controle de Colunas" />

            <Content>          
                {loading ? 
                    <ClipLoader css={cssspinner} />
                :

                    columnControl.length > 0 ? 

                        <Companies>   
                        {columnControl.map((c) => (
                            <>
                                <Items key={c}>
                                    <Link to={`/column-controls/${c}`}><h3>{c}</h3></Link>
                                </Items>
                            </>
                        ))}  
                        </Companies> 
                    : 
                    error ? 
                        <Warning>
                            <RiAlarmWarningLine color="#E74C3C" size={20} />
                            <span>Falha ao carregar processos</span>
                        </Warning>
                    :
        
                        <Warning>
                            <RiAlarmWarningLine color="#3498db" size={20} />
                            <span>Nenhum e-mail processado</span>
                        </Warning>
                }
            </Content>
        </>
    )
}

export default ColumnControls;
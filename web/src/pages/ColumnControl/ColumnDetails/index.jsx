import React, { useCallback, useState, useEffect } from 'react';

import Options from '../../../components/Options';
import SubHeader from '../../../components/SubHeader';
import Table from   '../../../components/Table';

import api from '../../../services/api';

import { Content } from './styles';

const columns = [
    { id: 0, description: 'Posição da Coluna', fieldCode: 'columnPosition'},
    { id: 1, description: 'Início', fieldCode: 'start'},
    { id: 2, description: 'Fim', fieldCode: 'end'},
    { id: 3, description: 'Tamanho', fieldCode: 'size'},
    { id: 4, description: 'Campo', fieldCode: 'field'},
    { id: 5, description: 'Código do Campo', fieldCode: 'fieldCode'},
    { id: 6, description: 'Tipo', fieldCode: 'typing'},
    { id: 7, description: 'Empresa', fieldCode: 'company'},
]

const ColumnDetail = (props) => {
    const[data, setData] = useState([]);

    const loadColumns = useCallback(async () => {
        try {
            const response = await api.get(`ColumnControl/get-company?company=${props.match.params.company}`);
            setData(response.data);
        } catch {

        } finally {

        }
    }, [props.match.params.company]);

    useEffect(() => {
        loadColumns();
    }, [loadColumns])

    return (
        <>
            <Options active={true} url="/column-controls" />

            <SubHeader title={`Controle de Colunas ${props.match.params.company}`} />

            <Content>
                <Table columns={columns} data={data} />
            </Content>
        </>
    )
}
export default ColumnDetail;

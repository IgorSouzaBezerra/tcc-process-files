import React, { useCallback } from 'react';
import { useHistory } from 'react-router-dom';

import api from '../../services/api';

import { Container, Button } from './styles';
import { Sucess } from '../../utils/toast';

const ProcessOptions = ({ uid }) => {
    const history = useHistory();
    const handleProcess = useCallback(async () => {
        await api.post(`Process/AlterStatus/${uid}`);
        Sucess('Processo Concluído com Sucesso.');
        history.push('/')
    }, [uid, history]);

    return (
        <Container>
            <div />
            <Button onClick={() => handleProcess()}>Enviar</Button>
        </Container>
    )
}

export default ProcessOptions;
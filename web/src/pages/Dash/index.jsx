import React, { useEffect, useState, useCallback, useMemo } from 'react';
import { Link } from 'react-router-dom';

import { Container, ControlItem, Item, Chart } from './styles';

import { Pie } from 'react-chartjs-2';

import api from '../../services/api';

const Dash = () => {
    const[pending, setPending] = useState(0);
    const[finished, setFinished] = useState(0);
    const[jobQtd, setJobQtd] = useState(0);

    const pendingChart = useMemo(() => pending, [pending]);
    const finishedChart = useMemo(() => finished, [finished]);

    const data = {
        labels: ['Atividades Pendentes', 'Atividades Concluídas'],
        datasets: [
          {
            label: '# of Votes',
            data: [pendingChart, finishedChart],
            backgroundColor: [
              'rgba(255, 99, 132, 1)',
              'rgba(54, 162, 235, 1)',
            ],
            borderColor: [
              'rgba(255, 99, 132, 0.2)',
              'rgba(54, 162, 235, 0.2)',
            ],
            borderWidth: 1,
          },
        ],
    };

    const loadQtdData = useCallback(async () => {
        const responsePending = await api.get(`Process/getPending`);
        setPending(responsePending.data.length);

        const responseFinished = await api.get(`Process/getFinished`);
        setFinished(responseFinished.data.length);

        const responseJob = await api.get(`JobEvent/getQtdJob`);
        setJobQtd(responseJob.data);
    }, []);

    useEffect(() => {
        loadQtdData();
    }, [loadQtdData]);

    return (
        <Container>
            <ControlItem>
                <Link to="/process/getFinished">
                    <Item>
                        <span>Processos concluídos</span>
                        <h3>{finished}</h3>
                    </Item>
                </Link>
                <Link to="/process/getPending">
                    <Item>
                        <span>Processos pendentes</span>
                        <h3>{pending}</h3>
                    </Item>
                </Link>
                <Link to="/job">
                    <Item>
                        <span>Jobs processadas</span>
                        <h3>{jobQtd}</h3>
                    </Item>
                </Link>
            </ControlItem>
            {pending === 0 && finished === 0 ? 
                (null) 
                : 
                (<Chart>
                    <Pie data={data} />
                </Chart>)
            }
            
        </Container>
    );
}

export default Dash;

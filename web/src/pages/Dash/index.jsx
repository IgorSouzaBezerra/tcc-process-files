import React, { useMemo } from 'react';

import { Container, Chart } from './styles';

import Summary from '../../components/Summary';

import { Pie } from 'react-chartjs-2';

import { useSummary } from '../../context/useSummary';

const Dash = () => {
    const { pendings, finalized } = useSummary();

    const pendingsMemo = useMemo(() => pendings, [pendings]);
    const finalizedMemo = useMemo(() => finalized, [finalized]);

    const data = {
        labels: ['Atividades Pendentes', 'Atividades Concluídas'],
        datasets: [
          {
            label: '# of Votes',
            data: [pendingsMemo, finalizedMemo],
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

    return (
        <>
            <Summary />
            <Container>
               <Chart>
                    <Pie data={data} />
                </Chart>
            </Container>
        </>
    );
}

export default Dash;

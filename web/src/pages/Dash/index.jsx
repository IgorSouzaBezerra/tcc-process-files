import React, { useState } from 'react';
import { css } from "@emotion/core";
import ClipLoader from 'react-spinners/ClipLoader';

import { Container, Chart } from './styles';

import Summary from '../../components/Summary';
import { Error } from '../../utils/toast';

import { Pie } from 'react-chartjs-2';

import { useSummary } from '../../context/useSummary';

const cssspinner = css`
  display: block;
  margin: 0 auto;
  margin-top: 100px;
`;

const Dash = () => {
    const[loading, setLoading] = useState(false);
    const { pendings, finalized, loadSummary } = useSummary();

    try {
      setLoading(true);
      loadSummary();
    } catch {
      Error('Falha ao carregar Summario!');
    } finally { 
      setLoading(false);
    }

    const data = {
        labels: ['Atividades Pendentes', 'Atividades Concluídas'],
        datasets: [
          {
            label: '# of Votes',
            data: [pendings, finalized],
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
        {loading ? (
          <>
            <Summary />
            <Container>
              {pendings || finalized ? (
                <Chart>
                    <Pie data={data} />
                </Chart>
              ) : 
                null
              } 
            </Container>
          </>
        ) : (
          <ClipLoader css={cssspinner} />
        )}
      </>
    );
}

export default Dash;

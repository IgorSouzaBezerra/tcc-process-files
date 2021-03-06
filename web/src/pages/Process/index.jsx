import React, { useEffect, useCallback, useState } from 'react';
import { css } from "@emotion/core";
import { RiAlarmWarningLine } from 'react-icons/ri';
import { FcOvertime, FcSearch } from 'react-icons/fc';
import ClipLoader from 'react-spinners/ClipLoader';
import { Link } from 'react-router-dom';

import Options from '../../components/Options';
import SubHeader from '../../components/SubHeader';

import api from '../../services/api';
import { Error } from '../../utils/toast';

import { Content, ProcessDiv, Items, Warning } from './styles';

import Empty from '../../assets/empty_email.svg';

const cssspinner = css`
  display: block;
  margin: 0 auto;
  margin-top: 100px;
`;

const Process = (props) => {
    const[process, setProcess] = useState([]);
    const[loading, setLoading] = useState(false);
    const[error, setError] = useState(false);

    const loadProcess = useCallback(async () => {
      try{
        setLoading(true);
        const response = await api.get(`Process/${props.match.params.endpoint}`);
        setProcess(response.data);
      } catch {
        setError(true);
        Error("Falha ao carregar processos...");
      } finally {
        setLoading(false);
      } 
    }, [props.match.params.endpoint]);
    
    useEffect(() => {
        loadProcess();
    }, [loadProcess]);

  return (
    <>
        <Options active={true} url="/" />
        <SubHeader title="Processos" />
        <Content>
          {loading ? 
            <ClipLoader css={cssspinner} />
          :
            process.length > 0 ? 
              (
                <ProcessDiv>
                  {process.map(p => (
                    <Items key={p.id}>
                      <Link to={`/process/${p.title}/${p.id}`}><FcSearch color="3498db" size={30} /></Link>
                      <p>{p.title}</p>
                      <p><FcOvertime size={30} /></p>
                    </Items>
                  ))}
                </ProcessDiv>
              )
            : 
              error ? 
                <Warning>
                  <RiAlarmWarningLine color="#E74C3C" size={20} />
                  <span>Falha ao carregar processos</span>
                </Warning>
              :
                <>
                  <Warning>
                    <RiAlarmWarningLine color="#3498db" size={20} />
                    <span>Nenhum e-mail processado</span>
                  </Warning>
                  <img src={Empty} alt="empty" />
                </>
          }
        </Content>
    </>
  );
}

export default Process;
import React, { useCallback, useEffect, useState } from 'react';
import ClipLoader from 'react-spinners/ClipLoader';
import { css } from "@emotion/core";

import { BsArrowLeft, BsArrowRight } from 'react-icons/bs';
import moment from 'moment';

import Header from '../../component/Header';
import Options from '../../component/Options';
import SubHeader from '../../component/SubHeader';

import api from '../../services/api';
import { Error } from '../../utils/toast';

import { Content, TableDiv, Tr, TrOptions, Th, Td } from './styles';

const columns = [
    { description: "Data de Início", fieldCode: "start", id: 0 },
    { description: "Horário de Início", fieldCode: "startTime", id: 0 },
    { description: "Data de Conclusão", fieldCode: "end", id: 1 },
    { description: "Horário de Conclusão", fieldCode: "endTime", id: 1 },
    { description: "Status", fieldCode: "jobStatus", id: 2 },
]

const cssspinner = css`
  display: block;
  margin: 0 auto;
  margin-top: 100px;
`;

const Job = () => {

    const[job, setJob] = useState([]);
    const[page, setPage] = useState(1);
    const[totalPages, setTotalPages] = useState(0);
    const[totalRecords, setTotalRecords] = useState(0);
    const[loading, setLoading] = useState(false);

    const loadData = useCallback(async (p) => {
        const response = await api.get(`jobevent/${p}`);
        setTotalRecords(response.data.totalItemCount);
        setTotalPages(response.data.pageCount);
        
        let jobs = []
        response.data.items.map(j => {
            const obj = {
                id: j.id,
                start: moment(j.start).format('DD/MM/YYYY'),
                startTime: moment(j.start).format('HH:mm:ss'),
                end: moment(j.end).format('DD/MM/YYYY'),
                endTime: moment(j.end).format('HH:mm:ss'),
                jobStatus: j.jobStatus ? "Finalizado" : "Executando"
            }
            return jobs.push(obj);
        });

        return jobs;
    }, []);

    const loadJobs = useCallback(async () => {
        try{
            setLoading(true);
            const jobs = await loadData(page);
            setJob(jobs);
        } catch {
            Error("Falha na busca das jobs...");
        } finally {
            setLoading(false);
        }
    }, [page, loadData]);

    useEffect(() => {
        loadJobs();
    }, [loadJobs]);

    const nextPage = useCallback(async () => {
        if (totalPages !== page)
            setPage(page + 1);
    }, [page, totalPages]);

    const previousPage = useCallback(async () => {
        if (!(page === 1))
            setPage(page - 1)
    }, [page]);


    return(
        <>
            <Header />
            <Options active={true} url="/" />
            <SubHeader title="Jobs" />
            {loading ? 
                <ClipLoader css={cssspinner} /> 
                : 

                (
                    <Content>
                        <TableDiv>
                            <thead>
                                <Tr>
                                    {columns.map(c => (
                                        <Th key={c.description}>{c.description}</Th>
                                    ))}
                                </Tr>
                            </thead>
                            <tbody>

                                {job.map((_, index) => (
                                    <Tr key={index}>
                                        {columns.map((d) => (
                                            <Td key={d.fieldCode}>{job[index][`${d.fieldCode}`]}</Td>
                                        ))}
                                    </Tr>
                                ))
                                }
                            </tbody>
                        </TableDiv>
                        <TableDiv>
                            <TrOptions>
                                    <Td>Página Anterior</Td>
                                    <Td>Página Atual</Td>
                                    <Td>Total de Página</Td>
                                    <Td >Quantidade de Registros</Td>
                                    <Td>Próxima Página</Td>
                            </TrOptions>
                            <TrOptions>
                                <Td onClick={() => previousPage()}><BsArrowLeft size={25} color="3498db" /></Td>
                                <Td>{page}</Td>
                                <Td>{totalPages}</Td>
                                <Td >{totalRecords}</Td>
                                <Td onClick={() => nextPage()}><BsArrowRight size={25} color="3498db" /></Td>
                            </TrOptions>
                        </TableDiv>
                    </Content>
                ) 
            }
        </>
    );
}

export default Job;

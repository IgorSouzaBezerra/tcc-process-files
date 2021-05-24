import React from 'react';
import { Link } from 'react-router-dom';
import { RiTimerLine } from 'react-icons/ri';
import { IoCheckmarkDone } from 'react-icons/io5';
import { BsCardChecklist } from 'react-icons/bs';

import { useSummary } from '../../context/useSummary';

import { Container } from './styles';

const Summary = () => {

  const { pendings, finalized, jobs } = useSummary();

  return (
    <Container>
      <Link to="/process/getPending">
        <div>
          <header>
            <p>Pendentes</p>
            <RiTimerLine size={30} />
          </header>
          <strong>{pendings}</strong>
        </div>
      </Link>
      <Link to="/process/getFinished">
        <div>
          <header>
            <p>Concluídos</p>
            <IoCheckmarkDone size={30} />
          </header>
          <strong>{finalized}</strong>
        </div>
      </Link>
      <Link to="/job">
        <div>
          <header>
            <p>Jobs</p>
            <BsCardChecklist size={30} />
          </header>
          <strong>{jobs}</strong>
        </div>
      </Link>
    </Container>
  );
}

export default Summary;

import React from 'react';
import { Link } from 'react-router-dom';

import { Container, MenuHeader, H4 } from './styles';

function Menu() {
  return (
    <>
      <Container>
        <MenuHeader>
          <Link to="/column-controls"><H4>CONTROLE COLUNAS</H4></Link>
          <Link to="/job"><H4>JOBS</H4></Link>
          <Link to="/users"><H4>USUÁRIOS</H4></Link>
        </MenuHeader>
      </Container>
    </>
  );
}

export default Menu;
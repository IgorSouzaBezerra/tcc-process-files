import React from 'react';
import { Link } from 'react-router-dom';
import { GoSignOut } from 'react-icons/go';

import Logo from '../../assets/logo.png';
import { Container, MenuHeader, H4, SignOut } from './styles';

import { useAuth } from '../../context/auth';

function Header() {
  const { Logout } = useAuth();
  return (
    <>
      <Container>
        <img src={Logo} alt="Logo" />
        <MenuHeader>
          <Link to="/"><H4>PROCESSOS</H4></Link>
          <Link to="/column-controls"><H4>CONTROLE COLUNAS</H4></Link>
          <Link to="/job"><H4>JOBS</H4></Link>
          <Link to="/users"><H4>USUÁRIOS</H4></Link>
        </MenuHeader>
        <SignOut onClick={() => Logout()}>
          <GoSignOut size={30} />
          <span>Sair</span>
        </SignOut>
      </Container>
    </>
  );
}

export default Header;

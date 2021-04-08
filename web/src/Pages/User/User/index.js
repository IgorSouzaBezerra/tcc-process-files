import React, { useCallback, useEffect, useState } from 'react';
import { Link } from 'react-router-dom';

import Header from '../../../component/Header';
import Options from '../../../component/Options';
import SubHeader from '../../../component/SubHeader';
import Footer from '../../../component/Footer';

import api from '../../../services/api';
import { Error } from '../../../utils/toast';

import { Container, Ul, Li } from './styles';

import AvatarImg from '../../../assets/avatar.png';

const User = () => {
    const[users, setUsers] = useState([]);

    const loadUsers = useCallback(async () => {
        try {
            const response = await api.get(`user`);
            setUsers(response.data);
        } catch {
            Error("Falha ao carregar usuários...");
        } finally {

        }
    }, []);

    useEffect(() => {
        loadUsers();
    }, [loadUsers]);

    return(
        <>
            <Header />
            <Options active={true} url="/" />
            <SubHeader title="Usuários" />

            <Container>
                <Ul>
                    {users.map(u => (
                        <Li key={u.id}>
                            <img src={AvatarImg} alt="" />
                            <Link to={`/user/${u.id}`}><strong>{u.name}</strong></Link>
                        </Li>
                    ))}

                </Ul>
            </Container>
            
            <Footer />
        </>
    );
}

export default User;

import React, { useCallback, useEffect, useState } from 'react';
import { Link } from 'react-router-dom';

import Options from '../../components/Options';
import SubHeader from '../../components/SubHeader';

import api from '../../services/api';
import { Error } from '../../utils/toast';

import { Container, Ul, Li } from './styles';

import AvatarImg from '../../assets/avatar.jpg';

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
            
        </>
    );
}

export default User;
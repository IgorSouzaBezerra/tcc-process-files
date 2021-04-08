import React, { useEffect, useCallback, useState } from 'react';

import Header from '../../../component/Header';
import Options from '../../../component/Options';
import SubHeader from '../../../component/SubHeader';
import Footer from '../../../component/Footer';

import Input from '../../../component/Input';

import { Form } from './styles';

import api from '../../../services/api';

const UserDetail = (props) => {
    const[name, setName] = useState("");
    const[email, setEmail] = useState("");
    const[password, setPassword] = useState("");
    const[userStatus, setUserStatus] = useState(0);

    const loadUser = useCallback(async () => {
        const id = props.match.params.id;
        const response = await api.get(`user/${id}`);
        
        setName(response.data.name);
        setEmail(response.data.email);
        setPassword(response.data.password);
        setUserStatus(response.data.userStatus);
    }, [props.match.params.id]);

    useEffect(() => {
        loadUser();
    }, [loadUser]);

    return(
        <>
            <Header />
            <Options active={true} url="/users" />
            <SubHeader title="Detalhes do Usuário" />
                <Form>
                    <Input type="text" value={name} disabled />
                    <Input type="text" value={email} disabled />
                    <Input type="password" value={password} disabled />
                    <Input type="text" value={userStatus ? "Desativado" : "Ativado"} disabled />

                </Form>
            <Footer />
        </>
    );
}

export default UserDetail;

import React, { useEffect, useCallback, useState } from 'react';
import { BsArrowLeft } from 'react-icons/bs';
import { GoSignOut } from 'react-icons/go';
import { useHistory } from 'react-router-dom';
import { AiOutlineUser } from 'react-icons/ai';
import { FiAtSign, FiLock } from 'react-icons/fi'
import { BiKey } from 'react-icons/bi';
import ClipLoader from 'react-spinners/ClipLoader';
import { useForm } from 'react-hook-form';
import { yupResolver } from '@hookform/resolvers/yup';

import  { valitionSchema } from './validation';

import { css } from "@emotion/core";

import { useAuth } from '../../context/auth';

import api from '../../services/api';

import { Error, Sucess } from '../../utils/toast';

import Input from '../../components/Input';
import Button from '../../components/Button';

import Avatar from '../../assets/avatar.jpg';

import { Container, OptionsProfile, Option, Content, ContentIMG, Form } from './styles';

const cssspinner = css`
    display: block;
    margin: 0 auto;
    size: 10px;
    margin-top: 250px;
`;

const MyProfile = (props) => {
    const[data, setsData] = useState({});
    const[loading, setLoading] = useState(false);
    const[loadingForm, setLoadingForm] = useState(false);

    const { Logout } = useAuth();
    const history = useHistory();

    const { register, handleSubmit, formState: { errors } } = useForm({
        resolver: yupResolver(valitionSchema),
    });

    const updateProfile = useCallback(async ({ id, name, email, oldPassword, password, confirmPassword }, e) => {
        e.preventDefault();
        setLoadingForm(true);
        try {
            const response = await api.put('User', {
                id, name, email, oldPassword, password, confirmPassword
            });
            setsData(response.data);
            Sucess('Dados atualizados com sucesso!');
        } catch (err) {
            if (err.response?.data) {
                Error(err.response.data);
            } else {
                Error("Server Internal Error.");
                history.push('/');
            }
        } finally {
            setLoadingForm(false);
        }
    }, [history]);
    
    const loadProfile = useCallback(async () => {
        setLoading(true);
        try {
            const id = props.match.params.id;
            const response = await api.get(`User/${id}`);
            setsData(response.data);
        } catch (err) {
            if (err.response?.data)
                Error(err.response.data);
            else 
                Error('Server Internal Error.');
                history.push('/');
        } finally {
            setLoading(false);
        }
    }, [props.match.params.id, history]); 
    
    useEffect(() => {
        loadProfile();
    }, [loadProfile]);

    return(
        <>
        {!loading ? (
            <Container>
                <OptionsProfile>
                    <Option>
                        <BsArrowLeft onClick={() => history.goBack()} size={30} color="3498db" />
                    </Option>
                    <Option onClick={() => Logout()}>
                        <GoSignOut size={30} />
                        <span>Sair</span>
                    </Option>
                </OptionsProfile>
                <Content>
                    <ContentIMG>
                        <img src={Avatar} alt="avatar" />
                    </ContentIMG>
                    <h3>{data.name}</h3>
                    
                    <Form onSubmit={(e) => handleSubmit(updateProfile)(e)}>
                        <Input icon={BiKey} placeholder="Id..." type="text" defaultValue={data.id} name="id" readonly="readonly" {...register("id")} />
                        <Input icon={AiOutlineUser} placeholder="Nome..." type="text" defaultValue={data.name} name="name" {...register("name")} />
                        {errors.name?.message}
                        <Input icon={FiAtSign} placeholder="Email..." type="text" defaultValue={data.email} name="email" {...register("email")} />
                        {errors.email?.message}
                        <Input icon={FiLock} placeholder="Senha atual..." type="password" name="oldPassword" {...register("oldPassword")} />
                        {errors.oldPassword?.message}
                        <Input icon={FiLock} placeholder="Nova senha..." type="password" name="password" {...register("password")} />
                        {errors.password?.message}
                        <Input icon={FiLock} placeholder="Confirmar senha..." type="password" name="confirmPassword" {...register("confirmPassword")} />
                        {errors.confirmPassword?.message}

                        <Button>{loadingForm ? <ClipLoader /> : 'Salvar'}</Button>
                    </Form>
                </Content>
            </Container>
        ) : (
            <ClipLoader css={cssspinner} />
        )}
        </>
    );
}   

export default MyProfile;

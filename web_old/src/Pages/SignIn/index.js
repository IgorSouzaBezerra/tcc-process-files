import React, { useCallback, useState } from 'react';
import { useForm } from 'react-hook-form';
import { yupResolver } from '@hookform/resolvers/yup';
import ClipLoader from 'react-spinners/ClipLoader';
import { css } from "@emotion/core";

import { schemaLogin } from './validation';
import { Container, Form, Input, Span, Button } from './styles';

import LogoImg from '../../assets/logo.png';

import { useAuth } from '../../context/auth';

const cssspinner = css`
  display: block;
  margin: 0 auto;
  size: 10px;
`;

const SignIn = () => {
    const { Login } = useAuth();
    const[loading, setLoading] = useState(false);

    const { register, handleSubmit, formState: { errors } } = useForm({
        resolver: yupResolver(schemaLogin)
    });

    const onSubmit = useCallback(async ({ email, password }) => {
        setLoading(true);
        await Login({ email, password });
        setLoading(false);
    }, [Login]);

    return(
        <Container>
            <img src={LogoImg} alt="Logo" />
            <Form onSubmit={handleSubmit(onSubmit)}>
                <Input type="text" {...register("email")} placeholder={"Email"} />
                <Span>{errors.email?.message}</Span>
                <Input type="password" {...register("password")} placeholder={"Senha"} />
                <Span>{errors.password?.message}</Span>
                <Button type="submit">{loading ? <ClipLoader css={cssspinner} /> : "Entrar"}</Button>
            </Form>
        </Container>
    );
}

export default SignIn;

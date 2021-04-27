import React, { useCallback, useState } from 'react';
import { FiAtSign, FiLock } from 'react-icons/fi'
import { useForm } from 'react-hook-form';
import { yupResolver } from '@hookform/resolvers/yup';
import ClipLoader from 'react-spinners/ClipLoader';

import { validationSchema } from './validation';

import Img from '../../assets/logo.png';

import Input from '../../components/Input';
import Button from '../../components/Button';

import { Container, ImgDiv, Form } from './styles';

import { useAuth } from '../../context/auth';

const SignIn = () => {
    const[loading, setLoading] = useState(false);

    const { Login } = useAuth();
    const { register, handleSubmit, formState: { errors } } = useForm({
        resolver: yupResolver(validationSchema),
    });

    const onSubmit = useCallback(async ({ email, password}) => {
        setLoading(true);
        await Login({ email, password });
        setLoading(false);
    }, [Login]);

    return (
        <Container>
            <ImgDiv>
                <img src={Img} alt="Logo" />
            </ImgDiv>
            <Form onSubmit={handleSubmit(onSubmit)}>
                <Input icon={FiAtSign} placeholder="Digite seu e-mail..." name="email" type="text" {...register("email")} />
                {errors.email?.message}
                <Input icon={FiLock} placeholder="Digite sua senha..." name="password" type="password" {...register("password")} />
                {errors.password?.message}
                <Button type="submit">{loading ? <ClipLoader size={18} /> : 'Entrar'}</Button>
            </Form>
        </Container>
    );
}

export default SignIn;

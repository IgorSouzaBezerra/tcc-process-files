import * as yup from 'yup';

export const validationSchema = yup.object().shape({
    email: yup.string().required("O e-mail é obrigatório.").email("O e-mail informado não é válido."),
    password: yup.string().required("A senha é obrigatória.").min(3, "A senha não atingiu o mínimo de 3 caracteres."),
});

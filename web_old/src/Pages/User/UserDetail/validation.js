import * as yup from 'yup';

export const schemaUser = yup.object().shape({
    name: yup.string().required("O nome é obrigatório."),
    email: yup.string().email().required("O e-mail é obrigatório.").email("O e-mail informado não é válido"),
    password: yup.string().required("A senha é obrigatória.").min(10, "Mínimo de 10 caracteres"),
});

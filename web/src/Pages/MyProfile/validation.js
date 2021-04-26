import * as yup  from 'yup';

export const valitionSchema = yup.object().shape({
    name: yup.string().required('O nome é obrigatório.'),
    email: yup.string().required("O e-mail é obrigatório.").email("O e-mail informado não é válido."),
    oldPassword: yup.string().required('A senha antiga é obrigatória.'),
    password: yup.string().required('A senha é obrigatória.'),
    confirmPassword: yup.string().oneOf([yup.ref('password'), null], 'As senhas devem corresponder.'),
});

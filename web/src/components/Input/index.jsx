import React from 'react';

import { Container, InputText } from './styles';

const Input = ({ placeholder, name, type, icon: Icon, defaultValue, readonly, ...rest }) => {
    return (
        <Container>
            { Icon && <Icon size={20} /> }
            <InputText placeholder={placeholder} defaultValue={defaultValue} name={name} type={type} readonly={readonly} {...rest} />
        </Container>
    );
}

export default Input;

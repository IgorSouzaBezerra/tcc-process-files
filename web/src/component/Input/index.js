import React from 'react';

import { Container, InputD } from './styles';

const Input = ({ value, type, disabled, placeholder }) => {
    return(
        <Container>
            <InputD type={type} defaultValue={value} disabled={disabled} placeholder={placeholder} />
        </Container>
    );
}

export default Input;

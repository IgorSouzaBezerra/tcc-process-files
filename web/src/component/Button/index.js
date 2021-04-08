import React from 'react';

import { ButtonDiv } from './styles';

const Button = ({ type, children }) => {
    return(

        <ButtonDiv type={type}>{children}</ButtonDiv>
    );
}

export default Button;
import React from 'react';

import { Container } from './styles';

const SubHeader = ({ title }) => {
    return(
        <Container>
            <h3>{title}</h3>
        </Container>
    );
}

export default SubHeader;
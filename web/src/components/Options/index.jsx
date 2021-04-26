import React from 'react';
import { Link } from 'react-router-dom';
import { BsArrowLeft } from 'react-icons/bs'

import { Container, Disabled } from './styles';

const Options = ({ active, url }) => {

    return (
        <>
            <Container>
                {active ?
                        <Link to={url}><BsArrowLeft color="3498db" size={40} /></Link>
                    :
                        <Disabled>
                            <BsArrowLeft color="3498db" size={40} />
                        </Disabled>
                }
            </Container>
        </>    
    )
}

export default Options;
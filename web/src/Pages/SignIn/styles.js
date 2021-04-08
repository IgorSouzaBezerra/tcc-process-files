import styled from 'styled-components';
import { shade } from 'polished';

export const Container = styled.div`
    max-width: 350px;
    margin: 0 auto;
    margin-top: 200px;

    text-align: center;

    img {
        width: 160px;
        height: 160px;
    }
`;

export const Form = styled.form`
    display: flex;
    flex-direction: column;
`;

export const Input = styled.input`
    border: 2px solid #5f5f5f;
    background: transparent;
    color: #FFFAFA;
    border-radius: 5px;
    background: #5f5f5f;
    padding: 10px;

    &::placeholder {
        color: #b2afaf;
    }

    &:focus {
        border: 2px solid #3498db;
        outline: none;
    }
`;

export const Span = styled.span`
    margin-bottom: 15px;
    color: #c53030;
`;

export const Button = styled.button`
    background: #3498db;
    height: 40px;
    border-radius: 5px;
    color: #FFFAFA;
    border: 0;  

    &:hover {
        background: ${shade(0.2, '#3498db')};
    }
`;

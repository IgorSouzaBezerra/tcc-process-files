import styled from 'styled-components';

export const Container = styled.div`
    max-width: 350px;
    margin: 0 auto;
    border-radius: 15px;

    margin-bottom: 10px;
    text-align: center;
    background: #5f5f5f;
    padding: 10px;
`;

export const InputD = styled.input`
    text-align: center;
    border: none;
    background: transparent;
    color: #FFFAFA;
    width: 100%;

    &::placeholder {
        color: #b2afaf;
    }
`;

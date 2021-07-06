import styled from 'styled-components';
import { shade } from 'polished';

export const Container = styled.div`
    height: 50px;
    width: 100%;
    position: fixed;
    bottom: 0;
    background: #5f5f5f;
    display: flex;
    align-items: center;
    justify-content: space-between;
`;

export const ButtonAprovar = styled.button`
    background: #07BC0C;
    height: 30px;
    border-radius: 2px;
    color: #FFFAFA;
    border: 0;
    padding: 5px;
    margin-right: 20px;
    &:hover {
        background: ${shade(0.2, '#07BC0C')};
    }
`;

export const ButtonReprovar = styled.button`
    background: #E74C3C;
    height: 30px;
    border-radius: 2px;
    color: #FFFAFA;
    border: 0;
    padding: 5px;
    margin-left: 20px;
    &:hover {
        background: ${shade(0.2, '#E74C3C')};
    }
`;
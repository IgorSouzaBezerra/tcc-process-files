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

export const Button = styled.button`
    background: #3498db;
    height: 30px;
    border-radius: 2px;
    color: #FFFAFA;
    border: 0;
    margin-right: 20px;
    padding: 5px;

    &:hover {
        background: ${shade(0.2, '#3498db')};
    }
`;

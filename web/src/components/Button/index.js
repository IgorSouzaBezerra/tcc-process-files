import styled from 'styled-components';
import { shade } from 'polished';

const Button = styled.button`
    width: 100%;
    padding: 10px;
    border-radius: 5px;
    margin-top: 7px;
    background-color: #3498db;

    border: 0;
    color: #FFFAFA;
    font-weight: 500;
    cursor: pointer;

    &:hover {
        background: ${shade(0.2, '#3498db')};
    }
`;

export default Button;

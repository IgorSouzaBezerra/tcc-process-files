import styled from 'styled-components';
import { shade } from 'polished';

export const ButtonDiv = styled.button`
    position:absolute; 
    top:50%;
    left:50%;
    transform: translate(-50%, -50%);

    background: #3498db;
    height: 40px;
    border-radius: 10px;
    border: 0;
    padding: 0 16px;
    color: #FFFAFA;
    font-weight: 500;
    width: 350px;

    &:hover {
    background: ${shade(0.2, '#3498db')};
  }
`;

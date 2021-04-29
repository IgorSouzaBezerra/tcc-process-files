import styled from 'styled-components';

export const Container = styled.div`
    max-width: 1100px;
    margin: 0 auto;
    
    display: flex;
    align-items: center;
    justify-content: center;
`;

export const MenuHeader = styled.div`
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: center;
    a {
        text-decoration: none;
        color: ${props => props.theme.colors.text};
    }
`;

export const H4 = styled.h4`
    margin-right: 20px;
    &:hover {
        color: #3498db;
    }
`;

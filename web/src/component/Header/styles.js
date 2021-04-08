import styled from 'styled-components';

export const Container = styled.div`
    max-width: 1100px;
    margin: 0 auto;
    
    display: flex;
    align-items: center;
    justify-content: space-between;

    img {
        width: 140px;
        height: 140px;
    }
`;

export const MenuHeader = styled.div`
    display: flex;
    flex-direction: row;
    align-items: center;

    a {
        text-decoration: none;
        color: #FFFAFA;
    }
`;

export const H4 = styled.h4`
    margin-right: 20px;

    &:hover {
        color: #3498db;
    }
`;

export const SignOut = styled.div`
    display: flex;
    flex-direction: column;

    &:hover {
        color: #3498db;
        cursor: pointer;
    }
`;

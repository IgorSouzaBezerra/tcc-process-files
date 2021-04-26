import styled from 'styled-components';

export const Content = styled.div`
    max-width: 1100px;
    margin: 0 auto;

    text-align: center;
    margin-top: 50px;
`;

export const Companies = styled.div`
    margin-top: 50px;
`;

export const Items = styled.div`
    display: flex;
    flex-direction: row;
    justify-content: space-around;
    margin-top: 15px;
    
    h3 {
        padding: 10px;
        background-color: #3498db;
        border-radius: 8px;
    }

    a {
        text-decoration: none;
        color: #FFFAFA;
    }
`;

export const Warning = styled.div`
    display: flex;
    align-items: center;
    justify-content: center;
    margin-top: 30px;

    svg {
        margin-right: 10px;
    }
`;

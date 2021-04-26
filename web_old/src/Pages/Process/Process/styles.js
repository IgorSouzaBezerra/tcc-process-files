import styled from 'styled-components';

export const Content = styled.div`
    max-width: 1100px;
    margin: 0 auto;

    text-align: center;

    img {
        margin-top: 50px;
    }
`;

export const ProcessDiv = styled.div`
    display: flex;
    flex-direction: column;

    margin-top: 30px;
`;

export const Items = styled.div`
    display: flex;
    align-items: center;
    justify-content: space-between;

    border-left: 6px solid #3498db;

    background-color: #5f5f5f;
    padding: 10px;
    border-radius: 0px 10px 10px 0px;
    margin-bottom: 15px;
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

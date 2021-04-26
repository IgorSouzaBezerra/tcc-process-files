import styled from 'styled-components';

export const Container = styled.div`
    max-width: 1100px;
    margin: 0 auto;
    margin-top: 50px;
`;

export const Ul = styled.ul`
    display: grid;
    grid-template-columns: repeat(6, 1fr);
    grid-gap: 24px;
    list-style: none;
`;

export const Li = styled.li`
    background: #5F5F5F;
    padding: 10px;
    border-radius: 3px;

    display: flex;
    flex-direction: column;
    align-items: center;
    text-align: center;

    img {
        width: 64px;
        height: 56px;
        border-radius: 50%;
        margin-bottom: 8px;
    }

    a {
        text-decoration: none;
        color: #FFFAFA;
    }
`;
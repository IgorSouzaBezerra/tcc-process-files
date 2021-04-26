import styled from 'styled-components';

export const Container = styled.div`
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;

    margin-top: 50px;
`;

export const ControlItem = styled.ul`
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    grid-gap: 200px;
    list-style: none;
    padding: 20px;
    background: ${props => props.theme.colors.div};
    border-radius: 5px;

    a {
        text-decoration: none;
    }
`;

export const Item = styled.li`
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;

    background: ${props => props.theme.colors.secundary};

    color: #FFF;
    font-weight: bold;
    border-radius: 10px;
    padding: 20px;
`;

export const Chart = styled.div`
    margin-top: 50px;
    width: 350px;
    height: 350px;
`;

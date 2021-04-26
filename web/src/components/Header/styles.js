import styled from 'styled-components';

export const Container = styled.div`
    height: 10vh;
    color: ${props => props.theme.colors.text};
    padding: 0 50px;
    
    display: flex;
    align-items: center;
    justify-content: space-between;

    img {
        border-radius: 50%;
        width: 30px;
    }
`;

export const SwitchOptions = styled.div`
    display: flex;
    align-items: center;

    svg {
        margin: 5px;
    }
`;

export const Options = styled.div`

    a {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        text-decoration: none;
        color: ${props => props.theme.colors.text};
    }
`;

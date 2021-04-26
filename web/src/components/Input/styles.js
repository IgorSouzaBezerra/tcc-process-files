import styled from 'styled-components';

export const Container = styled.div`
    display: flex;
    align-items: center;
    justify-content: center;

    svg {
        margin-right: 7px;
    }

    padding: 10px;
    border-radius: 5px;
    background: ${props => props.theme.component.input.color};
    
    & {
        margin: 7px;
    }
`;

export const InputText = styled.input`
    border: none;
    background: transparent;
    width: 300px;
    outline: none;
    font-size: 16px;
    color: ${props => props.theme.colors.text};
    width: 100%;

    &::placeholder {
        color: ${props => props.theme.component.input.placeholder};
    }
`;

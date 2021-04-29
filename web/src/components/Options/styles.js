import styled from 'styled-components';

export const Container = styled.div`
    max-width: 1100px;
    margin: 0 auto;

    a {
        text-decoration: none;
        color: #3498db;
    }
`;

export const Disabled = styled.div`
    svg {
        cursor: no-drop;
        opacity: 0.2;
    }
`;
import styled from 'styled-components';

export const TableDiv = styled.table`
    margin-bottom: 50px;
    margin: 0 auto;
    font-size: 12px;
    border-collapse: collapse;
    width: 90%;
    color: ${props => props.theme.colors.text};
`;

export const Tr = styled.tr`
    &:hover {
        background-color: #3498db;
    }
    &:nth-child(even) {
        background-color: ${props => props.theme.colors.div};
    }
`;

export const Th = styled.th`
    border: 1px solid #000;
    padding: 4px;
    text-align: center;
    padding-top: 5px;
    padding-bottom: 5px;
    text-align: center;
    background-color: #3498db;
`;

export const Td = styled.td`
    border: 1px solid #000;
    padding: 4px;
    text-align: center;
`;
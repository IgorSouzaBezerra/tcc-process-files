import styled from 'styled-components';

export const Content = styled.div`
    max-width: 1100px;
    margin: 0 auto;

    text-align: center;
    margin-top: 20px;
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

// Tabela temporária

export const TableDiv = styled.table`
    margin-bottom: 50px;
    margin: 0 auto;
    font-size: 12px;
    border-collapse: collapse;
    width: 90%;
    color: #FFFAFA;
`;

export const Tr = styled.tr`
    &:hover {
        background-color: #3498db;
    }

    &:nth-child(even) {
        background-color: #5f5f5f;
    }
`;

export const TrOptions = styled.tr`
    
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

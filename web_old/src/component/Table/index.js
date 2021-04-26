import React from 'react';

import { TableDiv, Tr, Th, Td } from './styles';

const Table = ({ columns, data }) => {
    return (
        <>
            <TableDiv>
                <thead>
                    <Tr>
                        {columns.map(c => (
                            <Th key={c.description}>{c.description}</Th>
                        ))}
                    </Tr>
                </thead>
                <tbody>

                    {data.map((_, index) => (
                        <Tr key={index}>
                            {columns.map((d) => (
                                <Td key={d.fieldCode}>{data[index][`${d.fieldCode}`]}</Td>
                            ))}
                        </Tr>
                    ))
                    }
                </tbody>
            </TableDiv>
        </>
    )
}

export default Table;
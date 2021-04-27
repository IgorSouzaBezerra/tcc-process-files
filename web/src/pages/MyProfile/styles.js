import styled from 'styled-components';

export const Container = styled.div`

`;

export const OptionsProfile = styled.div`
    display: flex;
    align-items: center;
    justify-content: space-around;

    margin-top: 10px;
`;

export const Option = styled.div`
    display: flex;
    flex-direction: column;

    &:hover {
        color: #3498db;
        cursor: pointer;
    }
`;

export const Content = styled.div`
    img {
        border-radius: 50%;
        width: 100px;
    }

    h3 {
        text-align: center;
        margin-bottom: 20px;
    }

    max-width: 500px;
    margin: 0 auto;
    margin-top: 20px;
`;

export const ContentIMG = styled.div`
    display: flex;
    align-items: center;
    justify-content: center;

    margin-bottom: 15px;
`;

export const Form = styled.form`
    
`;

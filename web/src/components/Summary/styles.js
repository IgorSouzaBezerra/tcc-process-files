import styled from "styled-components";

export const Container = styled.div`
  max-width: 1120px;
  margin: 0 auto;
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 2rem;
  color: #FFF;

  a {
    text-decoration: none;
    color: #FFF;
  }

  div {
    background: ${props => props.theme.colors.secundary};
    padding: 1.5rem 2rem;
    border-radius: 0.25rem;

    header {
      display: flex;
      align-items: center;
      justify-content: space-between;
      
    }

    strong {
      display: block;
      margin-top: 1rem;
      font-size: 2rem;
      font-weight: 500;
      line-height: 3rem;
    }

    transition: filter 0.2s;

    &:hover {
      filter: brightness(0.9);
    }
  }
`;
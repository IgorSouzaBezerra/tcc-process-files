import React, { useContext } from 'react';
import Switch from 'react-switch';
import { ThemeContext } from 'styled-components';
import { shade } from 'polished';
import { BsMoon } from 'react-icons/bs';
import { IoSunny } from 'react-icons/io5';
import { Link } from 'react-router-dom';

import Menu from '../Menu';

import { Container, Options, SwitchOptions } from './styles';

import { useAuth } from '../../context/useAuth';

import Avatar from '../../assets/avatar.jpg';

const Header = ({ toggleTheme }) => {
    const { user } = useAuth();
    const { colors, title } = useContext(ThemeContext);

    return (
        <Container>
            <SwitchOptions>
                { title === 'light' ? <IoSunny color="ffc222" size={20} /> : <BsMoon color="d4dee1" size={20} /> }
                <Switch 
                    onChange={toggleTheme}
                    checked={title === 'dark'}
                    checkedIcon={false}
                    uncheckedIcon={false}
                    height={10}
                    width={40}
                    handleDiameter={20}
                    offColor={shade(0.1, colors.primary)}
                    onColor={colors.secundary}
                />
            </SwitchOptions>
            { user &&
                <>
                    <Menu />
                    <Options>
                        <Link to={`/myprofile/${user.id}`} >
                            <img src={Avatar} alt="avatar" />
                            <span>{user.name}</span>
                        </Link>
                    </ Options>
                </>
            }
        </Container>
    );
}

export default Header;

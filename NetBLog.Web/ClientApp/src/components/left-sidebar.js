import React from 'react';
import { Container, Nav, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';

export default class LeftSidebar extends React.Component {
	render() {
		return (
			<Container className="left-sidebar">
        <div className="logo">
          <img src="http://zoyothemes.com/blogezy/images/logo.png" />
          <span className="text-muted">Graduating from the halls of the University Of Western Sydney in late 2011.</span>
        </div>
        <div id="sidebar-menu">
        <Nav vertical>
          <NavItem>
            <Link to="/">Home</Link>
          </NavItem>
          <NavItem>
            <Link to="/about">About</Link>
          </NavItem>
          <NavItem>
            <Link to="/contact">Contact</Link>
          </NavItem>
        </Nav>
        </div>
        <div className="copyright-box">
          2019 © Net BLog
        </div>			
			</Container>
		);
	}
}
import React, { Component } from 'react';
import { Container, Row, Col } from 'reactstrap';

import LeftSidebar from '../components/left-sidebar';

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <React.Fragment>
        <div className="topbar-mobile">
          <div className="logo">
            <a href="index.html"><img src="http://zoyothemes.com/blogezy/images/logo.png" alt="" className="" style={{height: '44px'}} /></a>
            <button className="button-menu-mobile">
              <i className="mdi mdi-menu"></i>
            </button>
          </div>
        </div>
        <Row>
          <Col className="side-menu" xs="2">
            <LeftSidebar />
          </Col>
          <Col>
            <Container>
              {this.props.children}                      
            </Container>
          </Col>
        </Row>
      </React.Fragment>
    );
  }
}

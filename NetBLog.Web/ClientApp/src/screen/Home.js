import React, { useState, Component } from 'react';
import { Container, Row, Col } from 'reactstrap';
import RightSidebar from '../components/right-sidebar';
import BlogCard from '../components/blog-card';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <Container>
        <Row>
          <Col lg="12">
            <div className="page-title">
              <Row>
                <Col md="9" xs="12">
                  <h2><span>News and Stories</span></h2>
                  <p className="subtitle text-muted">
                    Aenean sollicitudin, lorem quis bibendum auctor, nisi elit consequat ipsum, nec sagittis sem nibh id elit. 
                    Proin gravida nibh vel velit auctor Aenean sollicitudin, adipisicing elit sed lorem quis bibendum auctor.
                  </p>
                </Col>
              </Row>
            </div>
          </Col>
        </Row>
        <Row className="pt-5">
          <Col xl="8">
            <BlogCard />
            <BlogCard />
            <BlogCard />
            <BlogCard />
            <BlogCard />
            <BlogCard />
            <BlogCard />
          </Col>
          <Col xl="4"><RightSidebar /></Col>
        </Row>
      </Container>
    );
  }
}
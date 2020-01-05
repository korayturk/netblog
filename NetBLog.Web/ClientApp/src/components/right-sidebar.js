import React from 'react';
import { Container, InputGroup, Input, InputGroupAddon } from 'reactstrap';

export default class RightSidebar extends React.Component {
	render() {
		return (
			<Container className="right-sidebar">
				<aside className="widget widget_search">					
					<InputGroup>
						<Input placeholder="Search..." />
						<InputGroupAddon addonType="append">
							<button className="search-button">
								<span className="mdi mdi-magnify"></span>
							</button>
						</InputGroupAddon>
					</InputGroup>
				</aside>
				<aside className="widget about-widget">
					<div className="widget-title">About Me</div>
					<div className="text-center">
						<img src="http://zoyothemes.com/blogezy/images/photo.jpg" alt="About Me" className="rounded-circle" />
						<p>Quis vero phasellus hac nullam, in quam vitae duis adipiscing mauris leo, laoreet eget at quis, ante vestibulum vivamus vel. Sapien lobortis, eget orci purus amet pede, consectetur neque risus.</p>
					</div>
				</aside>
				<aside className="widget about-widget">
						<div className="widget-title">Subscribe &amp; Follow</div>
						<ul className="socials">
								<li><a href="http://facebook.com"><i className="mdi mdi-facebook"></i></a></li>
								<li><a href="http://twitter.com"><i className="mdi mdi-twitter"></i></a></li>
								<li><a href="http://instagram.com"><i className="mdi mdi-instagram"></i></a></li>
								<li><a href="http://pinterest.com"><i className="mdi mdi-pinterest"></i></a></li>
						</ul>
				</aside>
				<aside className="widget widget_categories">
						<div className="widget-title">Categories</div>
						<ul>
								<li><a href="#">Journey</a> (40)</li>
								<li><a href="#">Photography</a> (08)</li>
								<li><a href="#">Lifestyle</a> (11)</li>
								<li><a href="#">Food &amp; Drinks</a> (21)</li>
						</ul>
				</aside>
				<aside className="widget widget_recent_entries_custom">
						<div className="widget-title">Popular Posts</div>
						<ul>
								<li className="clearfix">
										<div className="wi">
												<a href="#"><img src="http://zoyothemes.com/blogezy/images/works/img1.jpg" alt="" className="img-fluid" /></a>
										</div>
										<div className="wb"><a href="#">Beautiful Day With Friends..</a> <span className="post-date">Jun 15, 2019</span></div>
								</li>
								<li className="clearfix">
										<div className="wi">
												<a href="#"><img src="http://zoyothemes.com/blogezy/images/works/img2.jpg" alt="" className="img-fluid" /></a>
										</div>
										<div className="wb"><a href="#">Nature valley with cooling..</a> <span className="post-date">Jun 10, 2019</span></div>
								</li>
								<li className="clearfix">
										<div className="wi">
												<a href="#"><img src="http://zoyothemes.com/blogezy/images/works/img3.jpg" alt="" className="img-fluid" /></a>
										</div>
										<div className="wb"><a href="#">15 Best Healthy and Easy Salad..</a> <span className="post-date">Jun 8, 2019</span></div>
								</li>
						</ul>
				</aside>
				<aside className="widget">
						<div className="widget-title">Text Widget</div>
						<p className="text-muted text-widget-des">Exercitation photo booth stumptown tote bag Banksy, elit small batch freegan sed. Craft beer elit seitan exercitation, photo booth et 8-bit kale chips proident chillwave deep v laborum. Aliquip veniam delectus, Marfa eiusmod Pinterest in do umami readymade swag. </p>
				</aside>
				<aside className="widget">
						<div className="widget-title">Archives</div>
						<ul>
								<li><a href="#">March 2019</a> (40)</li>
								<li><a href="#">April 2019</a> (08)</li>
								<li><a href="#">May 2019</a> (11)</li>
								<li><a href="#">Jun 2019</a> (21)</li>
						</ul>
				</aside>
				<aside className="widget widget_tag_cloud">
						<div className="widget-title">Tags</div>
						<div className="tagcloud">
								<a href="#">logo</a>
								<a href="#">business</a>
								<a href="#">corporate</a>
								<a href="#">e-commerce</a>
								<a href="#">agency</a>
								<a href="#">responsive</a>
						</div>
				</aside>
			</Container>
		);
	}
}
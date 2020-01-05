import React from 'react';
import { Container, Row, Col } from 'reactstrap';
import RightSidebar from '../components/right-sidebar';

export class Blog extends React.Component {
	render() {
		return (
			<Container>
				<Row className="pt-5">
					<Col xl="8">
						<article className="post">
							<div className="post-header">
								<h2 className="post-title"><a href="#">Runaway A Road Adventure</a></h2>
								<ul className="post-meta">
									<li><i className="mdi mdi-calendar"></i> July 03, 2019</li>
									<li><i className="mdi mdi-tag-text-outline"></i> <a href="#">Branding</a>, <a href="#">Design</a></li>
									<li><i className="mdi mdi-comment-multiple-outline"></i> <a href="#">3 Comments</a></li>
								</ul>
							</div>

							<div className="post-preview">
								<a href="blog-single.html"><img src="http://zoyothemes.com/blogezy/images/blog/blog-1.jpg" alt="" className="img-fluid rounded" /></a>
							</div>

							<div className="blog-detail-description">
								<p>Donec eleifend accumsan nibh eu efficitur. Vivamus lacinia ut turpis egestas convallis. Quisque nec accumsan justo. Maecenas auctor in nulla nec tincidunt. Pellentesque rutrum molestie tortor, ut egestas risus commodo a. Praesent a orci nec libero fringilla euismod eu id massa. Nunc eget bibendum odio, sed sodales eros.Vivamus lacinia, mi eu ultrices mattis.</p>

								<blockquote className="blockquote text-center">
									<h6 className="mb-0 blockquote-text">Praesent consectetur vel dui sed molestie. Aliquam imperdiet cursus dapibus. Quisque vestibulum blandit tellus, nec volutpat turpis. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</h6>
									<footer className="blockquote-footer mt-2">Someone famous in <cite title="Source Title">Source Title</cite></footer>
								</blockquote>

								<p>Quisque nec accumsan justo. Maecenas auctor in nulla nec tincidunt. Pellentesque rutrum molestie tortor, ut egestas risus commodo a. Praesent a orci nec libero fringilla euismod eu id massa. Nunc eget bibendum odio, sed sodales eros.Vivamus lacinia, mi eu ultrices mattis.</p>

								<div className="mt-5">
									<h6>Tags:</h6>
									<div className="tagcloud">
										<a href="#">logo</a>
										<a href="#">business</a>
										<a href="#">agency</a>
									</div>
								</div>

								<div className="media post-author-box">
									<img className="d-flex mr-3 rounded-circle" src="http://zoyothemes.com/blogezy/images/user/user-5.png" alt="Generic placeholder image" />
									<div className="media-body">
										<h4 className="media-heading"><a href="">Michelle Durant</a></h4>
										<p className="mb-0">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae. Sed dui lorem, adipiscing in adipiscing et, interdum nec metus. Mauris ultricies, justo eu convallis placerat, felis enim.</p>

										<ul className="socials list-unstyled mb-0 mt-3">
											<li><a href="http://facebook.com"><i className="mdi mdi-facebook"></i></a></li>
											<li><a href="http://twitter.com"><i className="mdi mdi-twitter"></i></a></li>
											<li><a href="http://instagram.com"><i className="mdi mdi-instagram"></i></a></li>
											<li><a href="http://pinterest.com"><i className="mdi mdi-pinterest"></i></a></li>
										</ul>
									</div>
								</div>

								<div className="mt-5 text-center">
									<h5 className="page-title-alt"><span>You Might Also Like</span></h5>
								</div>

								<div className="row">
									<div className="col-sm-4">
										<article className="related-post">
											<div className="post-preview">
												<a href="blog-single.html"><img src="http://zoyothemes.com/blogezy/images/blog/blog-2.jpg" alt="" className="img-fluid rounded" /></a>
											</div>

											<div className="post-header">
												<h6><a href="single-post2.html" title="">15 Best Healthy and Easy Salad Recipes</a></h6>
												<p className="post-date">August 12, 2019</p>
											</div>
										</article>
									</div>
									<div className="col-sm-4">
										<article className="related-post">
											<div className="post-preview">
												<a href="blog-single.html"><img src="http://zoyothemes.com/blogezy/images/blog/blog-3.jpg" alt="" className="img-fluid rounded" /></a>
											</div>

											<div className="post-header">
												<h6><a href="single-post2.html" title="">The planet doesn’t need saving. We do.</a></h6>
												<p className="post-date">August 17, 2019</p>
											</div>
										</article>
									</div>
									<div className="col-sm-4">
										<article className="related-post">
											<div className="post-preview">
												<a href="blog-single.html"><img src="http://zoyothemes.com/blogezy/images/blog/blog-4.jpg" alt="" className="img-fluid rounded" /></a>
											</div>

											<div className="post-header">
												<h6><a href="single-post2.html" title="">Modern City With Amazing Dark Blue Sea</a></h6>
												<p className="post-date">August 20, 2019</p>
											</div>
										</article>
									</div>
								</div>

								<div className="mt-5">
									<h5 className="page-title-alt"><span>Comments</span></h5>
								</div>

								<ul className="media-list list-unstyled">

									<li className="media">
										<img className="d-flex mr-3 rounded-circle" src="http://zoyothemes.com/blogezy/images/user/user-5.png" alt="Generic placeholder image" />
										<div className="media-body">
											<a href="#" className="text-custom reply-btn"><i className="mdi mdi-reply"></i>&nbsp; Reply</a>
											<h4 className="media-heading"><a href="">Michelle Durant</a></h4>
											<p className="text-muted post-date">Jun 23, 2019, 11:45 am</p>
											<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae. Sed dui lorem, adipiscing in adipiscing et, interdum nec metus. Mauris ultricies, justo eu convallis placerat, felis enim.</p>
										</div>
									</li>

									<li className="media">
										<img className="d-flex mr-3 rounded-circle" src="http://zoyothemes.com/blogezy/images/user/user-2.png" alt="Generic placeholder image" />
										<div className="media-body">
											<a href="#" className="text-custom reply-btn"><i className="mdi mdi-reply"></i>&nbsp; Reply</a>
											<h4 className="media-heading"><a href="">Ronda Otoole</a></h4>
											<p className="text-muted post-date">Jun 23, 2019, 11:45 am</p>
											<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae. Sed dui lorem, adipiscing in adipiscing et, interdum nec metus. Mauris ultricies, justo eu convallis placerat, felis enim.</p>

											<div className="media">
												<img className="d-flex mr-3 rounded-circle" src="http://zoyothemes.com/blogezy/images/user/user-3.png" alt="Generic placeholder image" />
												<div className="media-body">
													<a href="#" className="text-custom reply-btn"><i className="mdi mdi-reply"></i>&nbsp; Reply</a>
													<h4 className="media-heading"><a href="">James Whitley</a></h4>
													<p className="text-muted post-date">Jun 23, 2019, 11:45 am</p>
													<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae. Sed dui lorem, adipiscing in adipiscing et, interdum nec metus. Mauris ultricies, justo eu convallis placerat, felis enim.</p>
												</div>
											</div>
										</div>
									</li>

									<li className="media">
										<img className="d-flex mr-3 rounded-circle" src="http://zoyothemes.com/blogezy/images/user/user-4.png" alt="Generic placeholder image" />
										<div className="media-body">
											<a href="#" className="text-custom reply-btn"><i className="mdi mdi-reply"></i>&nbsp; Reply</a>
											<h4 className="media-heading"><a href="">Kimberly Chretien</a></h4>
											<p className="text-muted post-date">Jun 23, 2019, 11:45 am</p>
											<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae. Sed dui lorem, adipiscing in adipiscing et, interdum nec metus. Mauris ultricies, justo eu convallis placerat, felis enim.</p>
										</div>
									</li>

									<li className="media">
										<img className="d-flex mr-3 rounded-circle" src="http://zoyothemes.com/blogezy/images/user/user-6.png" alt="Generic placeholder image" />
										<div className="media-body">
											<a href="#" className="text-custom reply-btn"><i className="mdi mdi-reply"></i>&nbsp; Reply</a>
											<h4 className="media-heading"><a href="">Michelle Durant</a></h4>
											<p className="text-muted post-date">Jun 23, 2019, 11:45 am</p>
											<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra euismod odio, gravida pellentesque urna varius vitae. Sed dui lorem, adipiscing in adipiscing et, interdum nec metus. Mauris ultricies, justo eu convallis placerat, felis enim.</p>
										</div>
									</li>

								</ul>

								<div className="mt-5">
									<h5 className="page-title-alt"><span>Leave a reply</span></h5>
								</div>

								<form action="#" method="post" className="mt-4">
									<div className="row">
										<div className="col-sm-6">
											<div className="form-group">
												<input id="author" className="form-control" placeholder="Name*" name="author" type="text" required="" />
											</div>
										</div>

										<div className="col-sm-6">
											<div className="form-group">
												<input id="email" className="form-control" placeholder="Email*" name="email" type="text" required="" />
											</div>
										</div>
									</div>
									<div className="row">
										<div className="col-sm-12">
											<div className="form-group">
												<input id="subject" className="form-control" placeholder="Website" name="subject" type="text" />
											</div>
										</div>
									</div>

									<div className="row">
										<div className="col-sm-12">
											<div className="form-group">
												<textarea id="comment" className="form-control" rows="5" placeholder="Your Message*" name="comment" required=""></textarea>
											</div>
										</div>
									</div>

									<div className="row">
										<div className="col-sm-12">
											<div className="form-group">
												<button name="submit" type="submit" id="submit" className="btn btn-dark">Post Comment</button>
											</div>
										</div>
									</div>
								</form>

							</div>

						</article>
					</Col>
					<Col xl="4"><RightSidebar /></Col>
				</Row>
			</Container>
		);
	}
}
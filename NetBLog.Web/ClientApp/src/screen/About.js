import React from 'react';

export const About = () => {
	return (
		<section className="pt-5">
			<div className="container">
				<div className="row">
					<div className="col-12">
						<article className="post">
							<h5 className="text-center mt-0 mb-5 pb-3 text-uppercase"><b>About Me</b></h5>
							<div className="post-preview">
								<img src="http://zoyothemes.com/blogezy/images/blog/blog-5.jpg" alt="" className="img-fluid rounded" />
							</div>
							<div className="blog-detail-description">
								<p>Donec eleifend accumsan nibh eu efficitur. Vivamus lacinia ut turpis egestas convallis. Quisque nec accumsan justo. Maecenas auctor in nulla nec tincidunt. Pellentesque rutrum molestie tortor, ut egestas risus commodo a. Praesent a orci nec libero fringilla euismod eu id massa. Nunc eget bibendum odio, sed sodales eros.Vivamus lacinia, mi eu ultrices mattis.</p>
								<p>Donec eleifend accumsan nibh eu efficitur. Vivamus lacinia ut turpis egestas convallis. Quisque nec accumsan justo. Maecenas auctor in nulla nec tincidunt. Pellentesque rutrum molestie tortor, ut egestas risus commodo a. Praesent a orci nec libero fringilla euismod eu id massa. Nunc eget bibendum odio, sed sodales eros.Vivamus lacinia, mi eu ultrices mattis.</p>
								<blockquote className="blockquote text-center">
									<h6 className="mb-0 blockquote-text">Praesent consectetur vel dui sed molestie. Aliquam imperdiet cursus dapibus. Quisque vestibulum blandit tellus, nec volutpat turpis. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</h6>
									<footer className="blockquote-footer mt-2">Someone famous in <cite title="Source Title">Source Title</cite></footer>
								</blockquote>
								<p>Quisque nec accumsan justo. Maecenas auctor in nulla nec tincidunt. Pellentesque rutrum molestie tortor, ut egestas risus commodo a. Praesent a orci nec libero fringilla euismod eu id massa. Nunc eget bibendum odio, sed sodales eros.Vivamus lacinia, mi eu ultrices mattis.</p>
								<ul className="socials list-unstyled mb-0 text-center mt-5">
									<li><a href="http://facebook.com"><i className="mdi mdi-facebook"></i></a></li>
									<li><a href="http://twitter.com"><i className="mdi mdi-twitter"></i></a></li>
									<li><a href="http://instagram.com"><i className="mdi mdi-instagram"></i></a></li>
									<li><a href="http://pinterest.com"><i className="mdi mdi-pinterest"></i></a></li>
								</ul>
							</div>
						</article>
					</div>
				</div>
			</div>
		</section>
	);
}

export default About;
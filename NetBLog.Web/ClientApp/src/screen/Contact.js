import React from 'react';

export const Contact = () => {
	return (
		<section className="h-100vh pt-5">
			<div className="home-center">
				<div className="home-desc-center">
					<div className="container">
						<div className="row justify-content-center">
							<div className="col-8">
								<article className="post">
									<h5 className="text-center mt-0 mb-5 pb-3 text-uppercase"><b>Get In Touch</b></h5>
									<p className="text-center">Duis mollis eget augue et lobortis. Nam nunc justo, aliquet sed condimentum vel, faucibus in dolor. Proin eleifend hendrerit rhoncus.</p>

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
													<input id="subject" className="form-control" placeholder="Subject" name="subject" type="text" />
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
												<div className="form-group text-right">
													<button name="submit" type="submit" id="submit" className="btn btn-dark">Send</button>
												</div>
											</div>
										</div>
									</form>
									
								</article>
							</div>
						</div>
					</div>
				</div>
			</div>
		</section>
	);
}

export default Contact;
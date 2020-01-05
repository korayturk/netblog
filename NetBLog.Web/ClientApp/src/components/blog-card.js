import React from 'react';
import { Link } from 'react-router-dom'

const BlogCard = ()=>{
	return(
    <article className="post">
        <div className="post-header">
					<h2 className="post-title"><a href="#">Beautiful Day With Friends In Paris</a></h2>
					<ul className="post-meta">
						<li><i className="mdi mdi-calendar"></i> July 03, 2019</li>
						<li><i className="mdi mdi-tag-text-outline"></i> <a href="#">Branding</a>, <a href="#">Design</a></li>
						<li><i className="mdi mdi-comment-multiple-outline"></i> <a href="#">3 Comments</a></li>
					</ul>
        </div>
        <div className="post-preview">
          <a href="#"><img src="http://zoyothemes.com/blogezy/images/blog/blog-1.jpg" alt="" className="img-fluid rounded" /></a>
        </div>
        <div className="post-content">
          <p>Whether an identity or campaign, we make your brand visible, relevant and effective by placing the digital at the center of its ecosystem, without underestimating the power of traditional media. Whether an identity or campaign, we make your brand visible.</p>
        </div>
        <div>
          {/* <a href="/blog" className="btn btn-outline-custom">Read More <i className="mdi mdi-arrow-right"></i></a> */}
          <Link to="/blog" className="btn btn-outline-custom">Read More <i className="mdi mdi-arrow-right"></i></Link>
        </div>
    </article>);
}

export default BlogCard;
<html>
<style>
body {
   font-family: Arial, sans-serif;
   margin: 0;
   padding: 0;
   color: #333;
}

header {
   background-color: #00a2e8;
   padding: 10px 0;
   text-align: center;
}

.logo {
   font-size: 2em;
   font-weight: bold;
}

nav a {
   margin: 0 10px;
   color: #fff;
   text-decoration: none;
}

.hero {
   background-image: url('https://www.shutterstock.com/image-illustration/digital-generated-devices-on-desktop-260nw-1495869476.jpg');
   background-size: cover;
   height: 500px;
   display: flex;
   flex-direction: column;
   justify-content: center;
   align-items: center;
   text-align: center;
   color: #fff;
}

.hero-text {
   font-size: 3em;
}

.services, .portfolio, .blog {
   padding: 50px;
   text-align: center;
}

.services h2, .portfolio h2, .blog h2 {
   font-size: 2.5em;
   text-transform: uppercase;
}

.service, .project, .post {
   display: inline-block;
   width: 200px;
   height: 200px;
   margin: 10px;
   background-color: #f0f0f0;
}

footer {
   background-color: #222;
   color: #fff;
   padding: 20px;
   display: flex;
   justify-content: space-around;
}

footer a {
   color: #fff;
}

footer form {
   display: flex;
   flex-direction: column;
}

footer form input, footer form textarea {
   margin-bottom: 10px;
}

footer form button {
   background-color: #00a2e8;
   color: #fff;
   border: none;
   padding: 10px;
}
</style>
<body>
   <header>
       <div class="logo">
           <img src="data:image/jpeg;base64,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"
       </div>
           <nav>
           <a href="#">Home</a>
           <a href="#">About</a>
           <a href="#">Services</a>
           <a href="#">Portfolio</a>
           <a href="#">Contact</a>
       </nav>
   </header>
   <section class="hero">
       <div class="hero-text">
        DigitalCraft Works.
       </div>
       <button>Learn More</button>
   </section>
   <section class="services">
       <h2>Our Services</h2>
       <div class="service">
           <h3>Web Design & Development</h3>
           <p>Your website should be a unique reflection of your brand and its values. We use the latest technologies to create a visually stunning and functional website that meets your business needs.</p>
       </div>
       <div class="service">
           <h3>Digital Marketing</h3>
           <p>Our digital marketing services are designed to help you reach your target audience and increase your brand's online visibility.</p>
       </div>
       <div class="service">
           <h3>Research & Brainstorming</h3>
           <p>We believe in understanding your customers and their needs before creating a solution. Our research and brainstorming services will help you create a product that meets your customers' needs.</p>
       </div>
       <div class="service">
           <h3>Concepts & Sketching</h3>
           <p>Our concepts and sketching services will help you turn your ideas into a reality. We'll work with you to create a concept that fits your brand's identity and resonates with your audience.</p>
       </div>
       <div class="service">
           <h3>Execution & Drafting</h3>
           <p>Our execution and drafting services will help you turn your concept into a working product. We'll work with you to create a draft that meets your needs and is ready for production.</p>
       </div>
   </section>
   <section class="portfolio">
       <h2>View Portfolio</h2>
       <div class="project">
           <div class="project-image"></div>
           <p> Project 1</p>
           <p> E-commerce Redesign for Trendy Threads</p>
       </div>
       <div class="project">
           <div class="project-image"></div>
           <p>Project 2</p>
           <p>SEO & Digital Marketing for Green Energy Solutions</p>
       </div>
       <div class="project">
           <div class="project-image"></div>
           <p>Project 3</p>
           <p>Custom Web Application for FitLife Gym</p>
       </div>
   </section>
   <section class="blog">
       <h2>Recent Posts</h2>
       <div class="post">
           <h3>Blog Post 1</h3>
           <p>The Importance of Responsive Web Design in 2024.</p>
       </div>
       <div class="post">
           <h3>Blog Post 2</h3>
           <p>Top Digital Marketing Trends to Watch This Year.</p>
       </div>
       <div class="post">
           <h3>Blog Post 3</h3>
           <p> How User-Centered Design Enhances Customer Satisfaction.</p>
       </div>
   </section>
   <footer>
       <div class="footer-links">
           <a href="#">Home</a>
           <a href="#">About</a>
           <a href="#">Services</a>
           <a href="#">Portfolio</a>
           <a href="#">Blog</a>
       </div>
       <div class="footer-contact">
           <h3>Contact Information</h3>
           <p>123 Main St, Anytown, Anystate 12345</p>
           <p>Phone: (123) 455-5555</p>
           <p>Email: info@digitakcraftsworks.com</p>
       </div>
       <div class="footer-social">
           <a href="#">Facebook</a>
           <a href="#">Twitter</a>
           <a href="#">Instagram</a>
       </div>
       <div class="footer-copyright">
           <p>Copyright &copy; 2018</p>
       </div>
   </footer>
</body>
</html>
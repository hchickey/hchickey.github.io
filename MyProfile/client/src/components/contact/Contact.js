import './contact.css'

export const Contact = () => {
    return (
        <>
        <div class="container">
  <h1 className="contactHeader">Let's Connect! </h1>
  <form target="_blank" action="https://formsubmit.co/hchickey96@gmail.com" method="POST">
    <div class="form-group">
      <div class="form-row">
        <div class="col">
          <input type="text" name="name" class="form-control" placeholder="Full Name" required />
        </div>
        <div class="col">
          <input type="email" name="email" class="form-control" placeholder="Email Address" required />
        </div>
        <div class="col">
        <input type="hidden" name="_autoresponse" value="Thank you for contacting me. I look forward to connecting with you!" />
        </div>
        <div class="col">
            <input type="hidden" name="_template" value="box" />
        </div>
      </div>
    </div>
    <div class="form-group">
      <textarea placeholder="Your Message" class="form-control" name="message" rows="10" required></textarea>
    </div>
    <button type="submit" class="btn btn-lg btn-dark btn-block">Submit Form</button>
  </form>
</div>
        </>
    )
}
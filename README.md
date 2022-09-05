## What is Grant?
 For the purposes of residential, business, social, education, health, rural, urban, municipality cases to use, the government lease contract is required and which is necessary to apply. The lease contract is called a grant, and then the proposal of ownership is also called a grant.Nowadays, both contracts are called grants. 

 <p align="center">
	<img width="300" align="center" src="https://i.ibb.co/q7zbpLv/granted-Stamp-red.png">
</p>

### What Grant CAD can estimate?
 Grant CAD calculates the main things' requirements of any new house building materials what  municipality ask for house resistance. Such as,

* Cement
* Gravel
* Lime (Quicklime)
* Sand

### How Grant CAD calculation work?
 In 1:1:2:4 of 25  cubic foot concrete,
 cement will cost 1343.75 Ks, gravel will cost 20962.49 Ks, sand will cost 1250 and lime (quick lime) will cost 20962.49 Ks.
 The total estimation is 25649.99 Ks.

```c#
using System;
public calss Estimate{
    float Total(){

                ratio = Calculate.ShapeRatio(sh); 
                cuft = Calculate.CubicFeet(sh.Area, sh.Depth); 
                cement = Calculate.AverageCubic(sh.Cement, ratio, cuft); 
                gravel = Calculate.AverageCubic(sh.Gravel, ratio, cuft); 
                sand = Calculate.AverageCubic(sh.Sand, ratio, cuft); 
                Lime = Calculate.AverageCubic(sh.Lime, ratio, cuft); 
                cementprice = Calculate.MaterialPrice(cement, DataAccess.estimator.Cement_Price); 
                sandprice = Calculate.MaterialPrice(sand, DataAccess.estimator.Sand_Price); 
                gravelprice = Calculate.MaterialPrice(gravel, DataAccess.estimator.Gravel_Price); 
                limeprice = Calculate.MaterialPrice(Lime, DataAccess.estimator.Lime_Price); 
                float totalestimate = cementprice + sandprice + gravelprice + limeprice;
                return totalestimate;  
    }  
}
```
### How to use Grant CAD?
As estimation work per designed plan, first plot any shapes on the app. See the cost of plotted shapes by right-clicking on the object and click estimate. 
  <p align="center">
	<img width="5000" align="center" src="https://i.ibb.co/SPHGyLM/Sshot-Estimate.png">
</p>

### Submit (or) Report the proposal
After every shape or designed plans have drawn on the app, click on the report button on tools bar and see the result. The submitting could be done by the getting excel file from report form.
 <p align="center">
	<img width="5000" align="center" src="https://i.ibb.co/fN4F5QV/Sshot-All-Estimate.png">
</p>

### Pending...
Wood cost estimation.<br/>
Steel cost estimation.<br/>
Roof cost estimation.<br/>
Etc.....<br/>
<br/>
 <p align="center">
   <a href="https://www.dropbox.com/t/QyA1pTdwDm21DIBF"><img alt="Download" src="https://img.shields.io/badge/Download-Windows-%2300A4EF"></a>
  </p>
 <p align="center">
  <b>Price Citted From</b>  
  </p>
  <p align="center">
    <a href="https://www.amazon.com">
	<img src="https://1000logos.net/wp-content/uploads/2016/10/Amazon-Logo.png" width="160"></a>
  <a href="https://www.alibaba.com">
	<img src="https://1000logos.net/wp-content/uploads/2018/10/Alibaba-Logo.png" width="160"></a>
</p>


<p align="center">
<b> 🤝🏻 &nbsp;Creator Contact 🤝🏻 &nbsp;</b>
</p>
<p align="center">
<a href="https://www.linkedin.com/in/anil-oli-a0b773ab"><img alt="LinkedIn" src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white"></a>
  
<a href="mailto:yenainghtoo2@gmail.com"><img alt="Gmail" src="https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white"></a>
</p>

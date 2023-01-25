using System;
namespace CompanyBlogs.API.Models
{
	public static class DbInitializer
	{


		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			BlogDbContext context = applicationBuilder.ApplicationServices.CreateScope()
				.ServiceProvider.GetRequiredService<BlogDbContext>();

			var executiveBlog = new Blog { BlogName = "Executive Blogs" };
			var technicalBlog = new Blog { BlogName = "Technical Blogs" };
			var latestTrendBlog = new Blog { BlogName = "Latest Trends Blogs" };

			var aiCategoryBlog = new BlogCategory { CategoryName = "Artificial Intelligence" };
			var bigDataCategoryBlog = new BlogCategory { CategoryName = "Big Data Development" };
			var webCategoryBlog = new BlogCategory { CategoryName = "Web Development" };
			var mobileCategoryBlog = new BlogCategory { CategoryName = "Mobile Development" };

			var tensorFlowBlogPost = new BlogPost
			{
				Title = "Tensor Flow",
				Metadata = new Metadata() { Tags = { "AI", "Artificial Intelligence", "Tensor Flow" } },
				CoverPictureUrl = "Tensor Flow/TF_AI.png",
				ShortIntroduction = "TensorFlow has grown to be one of the most loved and widely adopted ML platforms in the industry and research. It is an open source machine learning platform that helps you develop and train machine learning models. At a high level, TensorFlow is a library that allows users to showcase unpredictable computation as a graph of data flows. It leverages various optimization techniques to make the calculation of mathematical expressions easier and more performant.",
				Description =
                """
								It was developed by the Google Brain Team within Google's Machine Intelligence research organization with an intention of doing research in the fields of Machine Learning and Deep Learning. At the time of writing this article, TensorFlow 2.0 was released with features that make this library more powerful and robust for creating Machine Learning models.

				Features of TensorFlow
				Machine/Deep Learning Services: TensorFlow was developed by the Google Brain Team within Google's Machine Intelligence research organization with an intention of doing research in the fields of Machine Learning and Deep Learning. This library exposes a lot of built-in algorithms and APIs for speech recognition, image recognition, image search, art creation, sentimental analysis, natural language processing, building neural networks and search engines.
				Multiple Language Support: TensorFlow offers developing machine learning models in a variety of programming languages. Some of the most common and famous APIs are exposed in languages including Python, Java, C++, Swift, Go and JavaScript. APIs have also been written by TensorFlow community contributors for C#, Haskell, Ruby, Rust and Scala.
				Multiple Platform Support: TensorFlow is cross-platform and can be used to build and train machine learning models on Linux, MacOS, Windows, Android, iOS and Raspberry Pi. It can run on multiple CPUs, GPUs, Mobile Operating Systems and TPUs. TensorFlow models can be deployed on different environments including cloud, on-prem, in the browser and on-device.
				Libraries & Extensions: To access domain specific application packages, building advanced models and methods and accelerating workflows, TensorFlow offers a wide variety of libraries, tools and extensions. These tools and libraries are domain specific and helps in solving a specific set of challenges.
				Vibrant Community: TensorFlow has grown to be the de facto ML platform and the favorite amongst Data Scientists, Researchers and machine learning experts. Being an open source library, TensorFlow encourages enthusiasts to contribute towards the community. This has made learning TensorFlow much easier due to the variety of information available through YouTube channels, Blogs, Forums and many other sources.
				Machine Learning Ecosystem
				Machine learning is vast and has a variety of technologies and libraries that help you develop and train Machine Learning models. In this section, we are going to take a quick look at those technologies.

				Keras: Keras is one of the leading high-level neural networks library written in Python. The reason why Keras has gained a lot of attention is because it is fast, modular and highly extensible. Keras doesn't handle low-level computation such as tensor products and convolutions. It relies on back-ends libraries to perform those low-level tasks. It is a high-level API wrapper that is capable of running on top of TensorFlow, Microsoft Cognitive Toolkit, R, Theano and PlaidML.
				Scikit-learn: Scikit-learn is a free machine learning library for Python programming language. It supports Python numerical and scientific libraries like NumPy and SciPy and offers a variety of supervised and unsupervised learning algorithms via a consistent interface in Python. The functionality that scikit-learn provides include Classification, Regression, Clustering, Dimensionality reduction, Model selection and Preprocessing. This library is robust and can be used to build Machine Learning models using Python for production.
				Microsoft Cognitive Toolkit: Microsoft Cognitive Toolkit, which is often abbreviated as CNTK, is an open source deep learning framework. It is one of the first deep-learning frameworks to support the Open Neural Network Exchange (ONNX) format which enables interoperability and allow us to run trained neural network on programs written in Java and C#. This toolkit can run on 64-bit Linux and 64-bit Windows operating systems, Universal Windows Platform (UMP) and Azure. It can be included as a library in programs written in C#, Java, Python and C++.
				Theano: Theano is yet another Python library that is used in building deep learning projects. Theano at its heart is a library that is built for evaluating complex mathematical expressions due to its tight integration with NumPy. Theano performs data-intensive computations much faster on the GPU than on a CPU. Theano isn’t actually a machine learning library as it doesn’t provide pre-built models to train our datasets. It is a mathematical library that provides tools to build our own machine learning models.
				Caffe: Caffe is yet another deep learning framework made with expression, speed, and modularity in mind. This framework was originally created by Yangqing Jia at UC Berkeley and was later developed by Berkeley AI Research (BAIR) and community contributors. This framework is well-tested and can be used for both academic research projects and industrial applications in AI. It offers model definitions, optimization settings, pre-trained models so that one can start right away. It is primarily for speed offers support for CPUs and GPUs. The framework is suitable for various architectures such as CNN (Convolutional Neural Network), Long-Term Recurrent Convolutional Network (LRCN), Long Short-Term Memory (LSTM ) or fully connected neural networks.
				Torch: Torch is an open source machine learning library that offers a wide range of algorithms for deep learning. It provides a flexible N-dimensional array or Tensor and offers support for linear algebra routines, numerical optimization routines, neural network, energy-based models and basic routines for indexing, slicing, transposing, type-casting, resizing, sharing storage and cloning. One famous machine learning library that has been built on top of Torch is PyTorch.
				Spark: Spark is an open-source, lightning fast, cluster computing framework that provides a fast and powerful engine for big data processing and creating machine learning models. Many data scientists prefer to use Spark’s scalable machine learning library that enables clustering, collaborative filtering and dimension reduction. This library consists of machine learning algorithms and utilities that includes Regression, Clustering, Classification, Decision trees, Random forests, Collaborative filtering, Dimensionality reduction, Topic Modeling and underlying optimization primitives. Its workflow utilities include feature transformation, machine learning pipeline construction, model evaluation and hyper-parameter tuning and persistence mechanism.
				Why is data science hard for beginners? It’s because the entire process is quite complex and requires expertise in many different facets including information retrieval, data engineering and data science. At the bare minimum, the process consists of the following steps:

				Data Collection
				Storage and data flow
				ETL (Extract, Transform and Load)
				Clean up and anomaly detection
				Representation
				Aggregation and training
				Evaluation
				Optimization
				""",
				IsActive = true,
				CreatedDate = DateTime.Now,
				UpdatedDate = DateTime.Now,
				Categories = { aiCategoryBlog , bigDataCategoryBlog },
				Blogs = { technicalBlog , latestTrendBlog }
			};

			//var pyTorchBlogPost = new


            if (!context.Blogs.Any())
			{
				//context.AddRange
				//(
				//	new Blog { BlogName = }
				//);
			}
		}


	}
}


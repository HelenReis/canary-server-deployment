# Deploy simulation using Kubernetes to run locally

![Badge em Desenvolvimento](http://img.shields.io/static/v1?label=STATUS&message=IN%20DEVELOPMENT&color=GREEN&style=for-the-badge)

Demonstration to how to deploy an application with canary server in Kubernetes running locally for testing purposes with zero dependencies of cloud services.

## :point_down: Prerequisites before running the project
- #### [Having Docker and Kubernetes installed](https://docs.docker.com/get-docker/)
- #### [Helm download](https://github.com/helm/helm/releases) (Note: Helm helps you manage Kubernetes applications)

## 🛠️ How to run locally (windows approach)

- `git clone https://github.com/HelenReis/canary-server-deployment`
- Open the *helm.exe* file downloaded on prerequisites on *CMD*
- Run `helm repo add ingress-nginx`
- Run `helm install my-ingresser ingress-nginx/ingress-nginx --namespace base`
- Run `kubectl get services -n base` to verify if the *nginx-controller* and *nginx-controller-admission* are both available
- Run `kubectl create namespace base` to create the namespace where the deployment resources will be placed
- Navigate to the *deployment* directory within the project on *CMD* and run `kubectl apply -f .` to apply all the resources that Kubernetes will use to run the application
- Navigate in your favorite browser to `kubernetes.docker.internal/weatherforecast` and have your application running on Kubernetes balancing the traffic in your on 30% on the canary server and 70% on the default server :blush:
- [You can look for more Kubernetes commands here and play with it locally](https://kubernetes.io/docs/reference/generated/kubectl/kubectl-commands) 

## :eyes: What's next
- It'll be built a pipeline file to automate the process

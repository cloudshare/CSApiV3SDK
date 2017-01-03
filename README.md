CloudShare API v3 SDKs
======================

This repository provides three "low level" API SDKs, each has a single function that both handles the HTTPS-requests for `use.cloudshare.com/api/v3/...` and takes care of the authentication. 
The SDK source files are open source software. They are licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0).

Each directory contains a language specific implementation and has its own README.md file, in order to help you get started quickly.

## Python SDK

The Python SDK has moved here: [cloudshare-py-sdk](https://github.com/cloudshare/cloudshare-py-sdk), and you can now install it with `pip install cloudshare`.

## Go SDK

Our Go SDK can be found [here](https://github.com/cloudshare/go-sdk).

It is a work in progress, offering generic REST API wrapper functions that support all API operations, and a subset of the API as typed Go structs and functions (for the most common operations). Feel free to send us a pull-request if you've wrapped more the API as native Go functions.

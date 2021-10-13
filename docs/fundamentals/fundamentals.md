---
title: Fundamentals
author: richard-preziosi
layout: default
nav_order: 0
permalink: fundamentals
has_children: true
---

# Elixir Engine Fundamentals

This article provides an overview of key topics for understanding how to develop Elixir Engine applications.

## The Application class

The `Startup` class is where:

* Services required by the application are configured.
* Log writers required by the applicaiton are configured.
* The game loop is managed and executed.

Here's a sample `Application` class:

For more information, see [Application class in Elixir Engine](fundamentals/application).

## Dependency injection (services)

Elixir Engine includes a built-in dependency injection (DI) framework that makes configured services available throughout an application. For example, a log writer is a services.

Code to configure (or *register*) services is added to the `Application.OnConfigureServices` method. For example:

<pre><code><span class="keyword">protected</span>&nbsp;<span class="keyword">override</span>&nbsp;<span class="keyword">void</span>&nbsp;<span class="method name">OnConfigureServices</span><span class="punctuation">(</span><span class="identifier - interface name - (TRANSIENT)">IServiceCollection</span>&nbsp;<span class="parameter name">serviceCollection</span><span class="punctuation">)</span>
<span class="punctuation">{</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span class="identifier - parameter name - (TRANSIENT)">serviceCollection</span><span class="operator">.</span><span class="extension method name - identifier - (TRANSIENT)">AddSingleton</span><span class="punctuation">&lt;</span><span class="class name - identifier - (TRANSIENT)">HealthUpdateBehavior</span><span class="punctuation">&gt;();</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span class="identifier - parameter name - (TRANSIENT)">serviceCollection</span><span class="operator">.</span><span class="extension method name - identifier - (TRANSIENT)">AddSingleton</span><span class="punctuation">&lt;</span><span class="identifier - interface name - (TRANSIENT)">IRandom</span><span class="punctuation">,</span>&nbsp;<span class="class name - identifier - (TRANSIENT)">FixedRandom</span><span class="punctuation">&gt;();</span>
<span class="punctuation">}</span></code></pre>

Services are typically resolved from DI using constructor injection. With constructor injection, a class declares a constructor parameter of either the required type or an interface. The DI framework provides an instance of this service at runtime.

The following example uses constructor injection to resolve an `IWindow` from DI:

<pre><code><span class="keyword">public</span>&nbsp;<span class="keyword">class</span>&nbsp;<span class="class name">BackgroundColorBehavior</span>&nbsp;<span class="punctuation">:</span>&nbsp;<span class="class name - identifier - (TRANSIENT)">UpdateBehavior</span>
<span class="punctuation">{</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span>&nbsp;<span class="keyword">readonly</span>&nbsp;<span class="identifier - interface name - (TRANSIENT)">IWindow</span>&nbsp;<span class="field name">window</span><span class="punctuation">;</span>
 
&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span>&nbsp;<span class="class name">BackgroundColorBehavior</span><span class="punctuation">(</span><span class="identifier - interface name - (TRANSIENT)">IWindow</span>&nbsp;<span class="parameter name">window</span><span class="punctuation">)</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span class="punctuation">{</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">this</span><span class="operator">.</span><span class="field name - identifier - (TRANSIENT)">window</span>&nbsp;<span class="operator">=</span>&nbsp;<span class="identifier - parameter name - (TRANSIENT)">window</span><span class="punctuation">;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span class="punctuation">}</span>
 
&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment">//&nbsp;...</span>
 
&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span>&nbsp;<span class="keyword">void</span>&nbsp;<span class="method name">ChangeBackgroundColor</span><span class="punctuation">(</span><span class="identifier - struct name - (TRANSIENT)">Color</span>&nbsp;<span class="parameter name">color</span><span class="punctuation">)</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span class="punctuation">{</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword - unnecessary code - (TRANSIENT)">this</span><span class="operator">.</span><span class="field name - identifier - (TRANSIENT)">window</span><span class="operator">.</span><span class="identifier - property name - (TRANSIENT)">BackgroundColor</span>&nbsp;<span class="operator">=</span>&nbsp;<span class="identifier - parameter name - (TRANSIENT)">color</span><span class="punctuation">;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span class="punctuation">}</span>
<span class="punctuation">}</span></code></pre>

For more information, see [Dependency Injection in Elixir Engine](dependency-injection).

## Logging

Elixir Engine supports a logging API that works with a variety of built-in and third-party logging providers. Available providers include:

* Console
* Debug
* Event Tracing on Windows
* Windows Event Log
* TraceSource

To create logs, resolve an `ILogger<TCategoryName>` service from dependency injection (DI) and call logging methods such as `LogInformation`. For example:

<pre><code><span class="keyword">public</span>&nbsp;<span class="keyword">class</span>&nbsp;<span class="class name">HealthUpdateBehavior</span>&nbsp;<span class="punctuation">:</span>&nbsp;<span class="class name - identifier - (TRANSIENT)">UpdateBehavior</span>
<span class="punctuation">{</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span>&nbsp;<span class="keyword">readonly</span>&nbsp;<span class="identifier - interface name - (TRANSIENT)">ILogger</span>&nbsp;<span class="field name">logger</span><span class="punctuation">;</span>
 
&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span>&nbsp;<span class="class name">HealthUpdateBehavior</span><span class="punctuation">(</span><span class="identifier - interface name - (TRANSIENT)">ILogger</span><span class="punctuation">&lt;</span><span class="class name - identifier - (TRANSIENT)">HealthUpdateBehavior</span><span class="punctuation">&gt;</span>&nbsp;<span class="parameter name">logger</span><span class="punctuation">)</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span class="punctuation">{</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">this</span><span class="operator">.</span><span class="field name - identifier - (TRANSIENT)">logger</span>&nbsp;<span class="operator">=</span>&nbsp;<span class="identifier - parameter name - (TRANSIENT)">logger</span><span class="punctuation">;</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span class="punctuation">}</span>
 
&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment">//&nbsp;...</span>
 
&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span>&nbsp;<span class="keyword">void</span>&nbsp;<span class="method name">RegenerateHealth</span><span class="punctuation">(</span><span class="class name - identifier - (TRANSIENT)">Entity</span>&nbsp;<span class="parameter name - unnecessary code - (TRANSIENT)">entity</span><span class="punctuation">)</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span class="punctuation">{</span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword - unnecessary code - (TRANSIENT)">this</span><span class="operator">.</span><span class="field name - identifier - (TRANSIENT)">logger</span><span class="operator">.</span><span class="extension method name - identifier - (TRANSIENT)">LogInformation</span><span class="punctuation">(</span><span class="string">&quot;Regenerating&nbsp;health!&quot;</span><span class="punctuation">);</span>
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment">//&nbsp;Entity&nbsp;health&nbsp;regeneration&nbsp;code&nbsp;removed.</span>
&nbsp;&nbsp;&nbsp;&nbsp;<span class="punctuation">}</span>
<span class="punctuation">}</span></code></pre>

Logging methods such as `LogInformation` support any number of fields. These fields are commonly used to construct a message `string`, but some logging providers send these to a data store as separate fields.

For more information, see [Logging in Elixir Engine](logging).
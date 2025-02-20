﻿// Copyright 2004-2022 Castle Project - http://www.castleproject.org/
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Castle.DynamicProxy.Tests.Records;

using NUnit.Framework;

namespace Castle.DynamicProxy.Tests
{
	[TestFixture]
	public class RecordsTestCase : BasePEVerifyTestCase
	{
		[Test]
		public void Can_proxy_empty_record()
		{
			_ = generator.CreateClassProxy<EmptyRecord>(new StandardInterceptor());
		}

		[Test]
		public void Can_proxy_derived_empty_record()
		{
			_ = generator.CreateClassProxy<DerivedEmptyRecord>(new StandardInterceptor());
		}
	}
}
